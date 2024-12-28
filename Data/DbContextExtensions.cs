using Microsoft.EntityFrameworkCore;

namespace GamingWebsiteBE.Data
{
    public static class DbContextExtensions
    {

        // Helper method to check for duplicates before adding values to the database
        public static void AddMissingEntities<T>(this DbContext context, IEnumerable<T> newEntities, Func<T, object> uniquePropertySelector) where T : class
        {
            // Get existing entities' unique properties
            var existingProperties = context.Set<T>()
                                            .AsNoTracking()                                                                // Optimizes performance by telling EF core they're read only
                                            .Select(uniquePropertySelector)
                                            .ToList();

            // Check for existing entities
            var entitiesToAdd = newEntities.Where(entity => !existingProperties.Contains(uniquePropertySelector(entity)))
                                                                               .Select(entity => entity)                  // Can be omitted
                                                                               .ToList();

            // Add missing entities
            if (entitiesToAdd.Any())
            {
                context.Set<T>().AddRange(entitiesToAdd);
                context.SaveChanges();
            }
        }

        // Helper method to update already existing database entries
        public static void UpdateExistingEntities<T>(this DbContext context, IEnumerable<T> updatedEntities, Func<T, object> uniquePropertySelector, Action<T, T> updateAction) where T : class
        {
            var existingEntities = context.Set<T>()
                                          .ToList();

            // Iterate through updated entities
            foreach ( var updatedEntity in updatedEntities )
            {
                // Find the matching existing entity
                var existingEntity = existingEntities.FirstOrDefault(e => uniquePropertySelector(e).Equals(uniquePropertySelector(updatedEntity)));

                // If a match is found apply the update action (Action<T, T>)
                if( existingEntity != null )
                {
                    updateAction(existingEntity, updatedEntity);
                }
            }

            // Save the database changes
            context.SaveChanges();
        }

    }
}
