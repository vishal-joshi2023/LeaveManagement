using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Data;
using AutoMapper;
using LeaveManagement.Models;

namespace LeaveManagement.Controllers
{
    public class LeaveTypesController : Controller
    {
         //Db copy
         private readonly ApplicationDbContext _context;


        //<Mappering congig permission>
        // so any controller can access db we need a copy private <-- dependancy injection
        // for db connection
        private readonly IMapper mapper;

        public LeaveTypesController(ApplicationDbContext context , IMapper Vmapper)
        {
            this.mapper = Vmapper;
            _context = context;
           
        }



        //Actions on Db

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        { 
            //MODEL
            // select * from leavesType 
            // _context(DB) -> leavetypes(table) 
            
            //Mapping leaveTypes -> LeavetypesVm
            var lt = mapper.Map<List<LeaveTypeVM>>(await _context.LeaveTypes.ToListAsync());
           
            //View
            return View(lt); 
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LeaveTypes == null)
            {
                return NotFound();
            }

            var leaveType = await _context.LeaveTypes.FirstOrDefaultAsync(m => m.Id == id);

            if (leaveType == null)
            {
                return NotFound();
            }

            return View(leaveType);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]


        //create([Bind("Name,DefaultDays,Id,DateCreated,DateModified")] ... )-> it is a filter - what comes and what needed (removed)

        public async Task<IActionResult> Create(LeaveTypeVM leaveTypevm)
        {
            //if data ip req not match is ret false 
            if (ModelState.IsValid){

                //we cant add leaveTypevm to DB_Context like _context.Add(leaveTypevm);
                //becz we dont have any db name leaveTypevm
                //so again we auto map db then it works fine

                var leaveType = mapper.Map<LeaveType>(leaveTypevm);
                _context.Add(leaveType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypevm);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LeaveTypes == null)
            {
                return NotFound();
            }

            var leaveType = await _context.LeaveTypes.FindAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            return View(leaveType);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,DefaultDays,Id,DateCreated,DateModified")] LeaveType leaveType)
        {
            if (id != leaveType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leaveType);
                    await _context.SaveChangesAsync();
                } 
                catch (DbUpdateConcurrencyException)  // Db consistancy protection
                {
                    if (!LeaveTypeExists(leaveType.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveType);
        }

        // GET: LeaveTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LeaveTypes == null)
            {
                return NotFound();
            }

            var leaveType = await _context.LeaveTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveType == null)
            {
                return NotFound();
            }

            return View(leaveType);
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LeaveTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");
            }
            var leaveType = await _context.LeaveTypes.FindAsync(id);
            if (leaveType != null)
            {
                _context.LeaveTypes.Remove(leaveType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeaveTypeExists(int id)
        {
          return _context.LeaveTypes.Any(e => e.Id == id);
        }
    }
}
