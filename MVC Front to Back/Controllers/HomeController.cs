using Microsoft.AspNetCore.Mvc;
using MVC_Front_to_Back.HomeViewModel;
using MVC_Front_to_Back.Models;

namespace MVC_Front_to_Back.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Feature> features = new List<Feature>();
            Feature feature = new Feature() { Id = 1, Description = "Yenilikler", Name = "qorqud" };
            Feature feature1 = new Feature() { Id = 2, Description = "Yenilikler1", Name = "qorqud1" };
            Feature feature2 = new Feature() { Id = 3, Description = "Yenilikler2", Name = "qorqud2" };
            Feature feature3 = new Feature() { Id = 4, Description = "Yenilikler3", Name = "qorqud3" };
            features.Add(feature);
            features.Add(feature1);
            features.Add(feature2);
            features.Add(feature3);



            List<Blog> blogs = new List<Blog>();    
            Blog blog = new Blog() { Id = 1 ,AuthorName="Dedeqorqud",Title="Myblog",Description="dede qorqud ve hekayeleri"};
            Blog blog1 = new Blog() { Id = 2 ,AuthorName="Dedeqorqud1",Title="Myblog1",Description="dede qorqud ve hekayeleri1"};
            Blog blog2 = new Blog() { Id = 3 ,AuthorName="Dedeqorqud2",Title="Myblog2",Description="dede qorqud ve hekayeleri2"};
            Blog blog3 = new Blog() { Id = 4 ,AuthorName="Dedeqorqud3",Title="Myblog3",Description="dede qorqud ve hekayeleri3"};
            blogs.Add(blog);
            blogs.Add(blog1);
            blogs.Add(blog2);
            blogs.Add(blog3);

            ViewModel viewModel = new ViewModel();
            viewModel.Blogs = blogs;
            viewModel.Feature = features;

            return View(viewModel);
        }
    }
}
