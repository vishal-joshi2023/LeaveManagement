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
using LeaveManagement.Contracts;
using LeaveManagement.Repositories;


// controller ab direct db se nhi juda hai repo ke throught op performed
namespace LeaveManagement.Controllers
{
    public class LeaveTypesController : Controller
    {

        // private readonly ApplicationDbContext _context; migrate  to  


        // new Ref of Db
        public readonly ILeaveTypeRepository leaveTypeRepository;


        // <Mappering congig permission>
        // so any controller can access db we need a copy private <-- dependancy injection
        // for db connection
        private readonly IMapper mapper;


        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            // _context = context;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;


        }

        // Actions on Db
        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            // MODEL (befor Repo)
            // select * from leavesType 
            // _context(DB) -> leavetypes(table
            // Mapping leaveTypes -> LeavetypesVm
            // var lt = mapper.Map<List<LeaveTypeVM>>(await _context.LeaveTypes.ToListAsync());

            //after making 
            var lt = mapper.Map<List<LeaveTypeVM>>(await leaveTypeRepository.GetAllAsync());

            return View(lt);
        }


        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }

            // if all cond. is ok return LeaveTypeVM view
            // map again

            var leaveTypevm = mapper.Map<LeaveTypeVM>(leaveType);

            return View(leaveTypevm);
        }


        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }


        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //same as details
            return await Details(id);
        }


        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        // create([Bind("Name,DefaultDays,Id,DateCreated,DateModified")] ... )-> it is a filter - what comes and what needed (removed)
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypevm)
        {
            // if data ip req not match is ret false 
            if (ModelState.IsValid)
            {

                // we cant add leaveTypevm to DB_Context like _context.Add(leaveTypevm);
                // becz we dont have any db name leaveTypevm
                // so again we auto map db then it works fine

                var leaveType = mapper.Map<LeaveType>(leaveTypevm);
                
                await leaveTypeRepository.AddAsync(leaveType);

                return RedirectToAction(nameof(Index));
            }

            return View(leaveTypevm);
        }


        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypevm)
        {
            if (id != leaveTypevm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // mapping
                    var leaveType = mapper.Map<LeaveType>(leaveTypevm);

                    await leaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)  // Db consistancy protection
                {
                    if (! await leaveTypeRepository.Exists(leaveTypevm.Id))
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
            return View(leaveTypevm);
        }


        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await leaveTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //convert simple bool -> async but this retun to Edit fun so noneed for this
        /*
        private async Task<bool> LeaveTypeExistsAsync(int id)
        {
            return await leaveTypeRepository.Exists(id);
        }
       */


        // This fun is not used now 
        // GET: LeaveTypes/Delete/5
        /* public async Task<IActionResult> Delete(int? id)
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
        */

    }
}
