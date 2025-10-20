using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Data;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobResultsController : ControllerBase
    {
        private readonly DBManager _context;

        public JobResultsController(DBManager context)
        {
            _context = context;
        }

        // GET: api/JobResults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobResult>>> GetJobResult()
        {
          if (_context.JobResult == null)
          {
              return NotFound();
          }
            return await _context.JobResult.ToListAsync();
        }

        // GET: api/JobResults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobResult>> GetJobResult(int? id)
        {
          if (_context.JobResult == null)
          {
              return NotFound();
          }
            var jobResult = await _context.JobResult.FindAsync(id);

            if (jobResult == null)
            {
                return NotFound();
            }

            return jobResult;
        }

        // PUT: api/JobResults/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobResult(int? id, JobResult jobResult)
        {
            if (id != jobResult.Id)
            {
                return BadRequest();
            }

            _context.Entry(jobResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobResultExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/JobResults
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobResult>> PostJobResult([FromBody]JobResult jobResult)
        {
          if (_context.JobResult == null)
          {
              return Problem("Entity set 'DBManager.JobResult'  is null.");
          }
            _context.JobResult.Add(jobResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJobResult", new { id = jobResult.Id }, jobResult);
        }

        // DELETE: api/JobResults/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobResult(int? id)
        {
            if (_context.JobResult == null)
            {
                return NotFound();
            }
            var jobResult = await _context.JobResult.FindAsync(id);
            if (jobResult == null)
            {
                return NotFound();
            }

            _context.JobResult.Remove(jobResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JobResultExists(int? id)
        {
            return (_context.JobResult?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
