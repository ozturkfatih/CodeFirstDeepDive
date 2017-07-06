using System;
using System.Diagnostics;
using CodeFirstDeepDive.Service;

namespace CodeFirstDeepDive
{
    public class AppRun
    {
        private readonly ILogService _logService;
        private readonly ITagService _tagService;
        private readonly ICategoryService _categoryService;
        public AppRun(ILogService logService, ITagService tagService, ICategoryService categoryService)
        {
            _logService = logService;
            _tagService = tagService;
            _categoryService = categoryService;
        }

        public void Run()
        {
            foreach (var category in _categoryService.GetList())
            {
                Console.Write($"\tId:{category.Id}\tCategory:{category.Name}\n");
            }
            foreach (var category in _categoryService.GetListLinq())
            {
                Console.Write($"\tId:{category.Id}\tCategory:{category.Name}\n");
            }

            Console.ReadKey();
        }
    }
}