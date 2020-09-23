using Epifania.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Epifania.Controllers.Administration
{
    public class UserPermissionsController : Controller
    {
        private readonly DataBaseContext _context;

        public UserPermissionsController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: UserPermissions
        public async Task<IActionResult> Index()
        {
            var dataBaseContext = _context.UserPermissions.Include(u => u.UserRole);
            return View(await dataBaseContext.ToListAsync());
        }

        // GET: UserPermissions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPermission = await _context.UserPermissions
                .Include(u => u.UserRole)
                .FirstOrDefaultAsync(m => m.UserPermissionId == id);
            if (userPermission == null)
            {
                return NotFound();
            }

            return View(userPermission);
        }

        // GET: UserPermissions/Create
        public IActionResult Create()
        {
            ViewData["UserRoleId"] = new SelectList(_context.UserRoles, "UserRoleId", "UserRoleId");
            return View();
        }

        // POST: UserPermissions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserPermissionId,Name,Description,UserRoleId")] UserPermission userPermission)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userPermission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserRoleId"] = new SelectList(_context.UserRoles, "UserRoleId", "UserRoleId", userPermission.UserRoleId);
            return View(userPermission);
        }

        // GET: UserPermissions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPermission = await _context.UserPermissions.FindAsync(id);
            if (userPermission == null)
            {
                return NotFound();
            }
            ViewData["UserRoleId"] = new SelectList(_context.UserRoles, "UserRoleId", "UserRoleId", userPermission.UserRoleId);
            return View(userPermission);
        }

        // POST: UserPermissions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserPermissionId,Name,Description,UserRoleId")] UserPermission userPermission)
        {
            if (id != userPermission.UserPermissionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userPermission);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserPermissionExists(userPermission.UserPermissionId))
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
            ViewData["UserRoleId"] = new SelectList(_context.UserRoles, "UserRoleId", "UserRoleId", userPermission.UserRoleId);
            return View(userPermission);
        }

        // GET: UserPermissions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPermission = await _context.UserPermissions
                .Include(u => u.UserRole)
                .FirstOrDefaultAsync(m => m.UserPermissionId == id);
            if (userPermission == null)
            {
                return NotFound();
            }

            return View(userPermission);
        }

        // POST: UserPermissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userPermission = await _context.UserPermissions.FindAsync(id);
            _context.UserPermissions.Remove(userPermission);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserPermissionExists(int id)
        {
            return _context.UserPermissions.Any(e => e.UserPermissionId == id);
        }
    }
}