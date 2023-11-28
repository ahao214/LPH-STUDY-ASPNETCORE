namespace Video.Service.Application.Example
{
    public class ExampleQueryHandler
    {
        /// <summary>
        /// This can use query's DbContext
        /// </summary>
        private readonly VideoDbContext _dbContext;

        public ExampleQueryHandler(VideoDbContext dbContext) => _dbContext = dbContext;

        [EventHandler]
        public Task GetListAsync(ExampleGetListQuery command)
        {
            //TODO:Get logic
            return Task.CompletedTask;
        }
    }
}
