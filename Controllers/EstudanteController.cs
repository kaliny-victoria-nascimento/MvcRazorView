using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

//herança 
public class EstudanteController : Controller
{
    //lista vazia para testar o if else:
    //private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>();

    private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel> {
        new EstudanteViewModel(1,"Maria", "Rua M", true),
        new EstudanteViewModel(2,"João", "Rua J", true),
        new EstudanteViewModel(3,"Pedro", "Rua P", false),
        new EstudanteViewModel(4,"Carla", "Rua C", true)
    };

    public IActionResult Index()
    { 
        return View(estudantes);
    }

    //detalhes
    public IActionResult Show(int id)
    {
        return View(estudantes[id-1]);
    }
}