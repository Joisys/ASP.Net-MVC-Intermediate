using System.Web.Mvc;
using Jo2me.Interface.Service;
using Jo2me.Model;
using Jo2me.Web.Models;

namespace Jo2me.Web.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        // GET: Location
        public ActionResult Index()
        {
            var locations = _locationService.GetLocations();
            return View(locations);
        }

        public ActionResult Detail(int id)
        {
            var location = _locationService.GetLocationById(id);
            return View(location);
        }

        public ActionResult Create()
        {
            return View(new LocationViewModel());
        }

        [HttpPost]
        public ActionResult Create(LocationViewModel model)
        {
            //var locationData = new Location();            
            //AutoMapper.Mapper.Map(createModel, model);
            _locationService.AddLocation(new Location
            {
                Name = model.Title
            });

            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var location = _locationService.GetLocationById(id);
            return View(new LocationViewModel
            {
                Id = location.Id,
                Title = location.Name
            });
        }

        [HttpPost]
        public ActionResult Update(int id, LocationViewModel model)
        {
            var location = _locationService.GetLocationById(id);
            if (location == null) return View(model);

            location.Name = model.Title;
            _locationService.UpdateLoaction(location);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var location = _locationService.GetLocationById(id);
            if (location == null) return RedirectToAction("Index");
            return View(new LocationViewModel
            {
                Id = location.Id,
                Title = location.Name
            });
        }

        [HttpPost]
        public ActionResult Delete(int id, LocationViewModel model)
        {
            var location = _locationService.GetLocationById(id);
            if (location == null) return RedirectToAction("Index");

            _locationService.DeleteLocation(id);

            return RedirectToAction("Index");
        }

    }
}