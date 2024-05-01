﻿using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetActorsAsync();
            return View(data);
        }

        //Get Request : Actors/Create
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")] Actor actor)
        {
            //
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetActorByIdAsync(id);

            if (actorDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(actorDetails);
            }
        }

        // Get: Actor/Create/Update
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetActorByIdAsync(id);

            if (actorDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(actorDetails);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName, ProfilePictureURL, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            else
            {
                await _service.UpdateAsync(id, actor);
                return RedirectToAction(nameof(Index));
            }
        }

        // Get: Actor/Create/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetActorByIdAsync(id);

            if (actorDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(actorDetails);
            }
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetActorByIdAsync(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                await _service.DeleteAsync(id);
            }
                return RedirectToAction(nameof(Index));
        }
    }
}
