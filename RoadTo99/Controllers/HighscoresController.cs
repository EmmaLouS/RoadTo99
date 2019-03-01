using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RoadTo99.Models;

namespace RoadTo99.Controllers
{
    public class HighscoresController : Controller
    {
        private readonly runescapeContext _context;

        public HighscoresController(runescapeContext context)
        {
            _context = context;
        }

        // GET: Highscores
        public async Task<IActionResult> Index()
        {
            var runescapeContext = _context.Highscore.Include(h => h.Player);
            return View(await runescapeContext.ToListAsync());
        }

        // GET: Highscores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var highscore = await _context.Highscore
                .Include(h => h.Player)
                .SingleOrDefaultAsync(m => m.HighscoreId == id);
            if (highscore == null)
            {
                return NotFound();
            }

            return View(highscore);
        }

        // GET: Highscores/Create
        public IActionResult Create()
        {
            ViewData["PlayerId"] = new SelectList(_context.Player, "PlayerId", "PlayerName");
            return View();
        }

        // POST: Highscores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HighscoreId,PlayerId,DownloadDate,TotalRank,TotalLevel,TotalXp,AttackRank,AttackLevel,AttackXp,DefenceRank,DefenceLevel,DefenceXp,StrengthRank,StrengthLevel,StrengthXp,HitpointsRank,HitpointsLevel,HitpointsXp,RangedRank,RangedLevel,RangedXp,PrayerRank,PrayerLevel,PrayerXp,MagicRank,MagicLevel,MagicXp,CookingRank,CookingLevel,CookingXp,WoodcuttingRank,WoodcuttingLevel,WoodcuttingXp,FletchingRank,FletchingLevel,FletchingXp,FishingRank,FishingLevel,FishingXp,FiremakingRank,FiremakingLevel,FiremakingXp,CraftingRank,CraftingLevel,CraftingXp,SmithingRank,SmithingLevel,SmithingXp,MiningRank,MiningLevel,MiningXp,HerbloreRank,HerbloreLevel,HerbloreXp,AgilityRank,AgilityLevel,AgilityXp,ThievingRank,ThievingLevel,ThievingXp,SlayerRank,SlayerLevel,SlayerXp,FarmingRank,FarmingLevel,FarmingXp,RunecraftRank,RunecraftLevel,RunecraftXp,HunterRank,HunterLevel,HunterXp,ConstructionRank,ConstructionLevel,ConstructionXp")] Highscore highscore)
        {
            if (ModelState.IsValid)
            {
                _context.Add(highscore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlayerId"] = new SelectList(_context.Player, "PlayerId", "PlayerName", highscore.PlayerId);
            return View(highscore);
        }

        // GET: Highscores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var highscore = await _context.Highscore.SingleOrDefaultAsync(m => m.HighscoreId == id);
            if (highscore == null)
            {
                return NotFound();
            }
            ViewData["PlayerId"] = new SelectList(_context.Player, "PlayerId", "PlayerName", highscore.PlayerId);
            return View(highscore);
        }

        // POST: Highscores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HighscoreId,PlayerId,DownloadDate,TotalRank,TotalLevel,TotalXp,AttackRank,AttackLevel,AttackXp,DefenceRank,DefenceLevel,DefenceXp,StrengthRank,StrengthLevel,StrengthXp,HitpointsRank,HitpointsLevel,HitpointsXp,RangedRank,RangedLevel,RangedXp,PrayerRank,PrayerLevel,PrayerXp,MagicRank,MagicLevel,MagicXp,CookingRank,CookingLevel,CookingXp,WoodcuttingRank,WoodcuttingLevel,WoodcuttingXp,FletchingRank,FletchingLevel,FletchingXp,FishingRank,FishingLevel,FishingXp,FiremakingRank,FiremakingLevel,FiremakingXp,CraftingRank,CraftingLevel,CraftingXp,SmithingRank,SmithingLevel,SmithingXp,MiningRank,MiningLevel,MiningXp,HerbloreRank,HerbloreLevel,HerbloreXp,AgilityRank,AgilityLevel,AgilityXp,ThievingRank,ThievingLevel,ThievingXp,SlayerRank,SlayerLevel,SlayerXp,FarmingRank,FarmingLevel,FarmingXp,RunecraftRank,RunecraftLevel,RunecraftXp,HunterRank,HunterLevel,HunterXp,ConstructionRank,ConstructionLevel,ConstructionXp")] Highscore highscore)
        {
            if (id != highscore.HighscoreId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(highscore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HighscoreExists(highscore.HighscoreId))
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
            ViewData["PlayerId"] = new SelectList(_context.Player, "PlayerId", "PlayerName", highscore.PlayerId);
            return View(highscore);
        }

        // GET: Highscores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var highscore = await _context.Highscore
                .Include(h => h.Player)
                .SingleOrDefaultAsync(m => m.HighscoreId == id);
            if (highscore == null)
            {
                return NotFound();
            }

            return View(highscore);
        }

        // POST: Highscores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var highscore = await _context.Highscore.SingleOrDefaultAsync(m => m.HighscoreId == id);
            _context.Highscore.Remove(highscore);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HighscoreExists(int id)
        {
            return _context.Highscore.Any(e => e.HighscoreId == id);
        }
    }
}
