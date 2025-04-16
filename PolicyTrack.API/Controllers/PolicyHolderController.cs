using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PolicyTrack.API.Data;
using PolicyTrack.API.Models;

namespace PolicyTrack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyHoldersController : ControllerBase
    {
        private readonly PolicyTrackContext _context;

        public PolicyHoldersController(PolicyTrackContext context)
        {
            _context = context;
        }

        // GET: api/PolicyHolders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PolicyHolder>>> GetPolicyHolders()
        {
            return await _context.PolicyHolders.Include(p => p.Policies).ToListAsync();
        }

        // GET: api/PolicyHolders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PolicyHolder>> GetPolicyHolder(int id)
        {
            var policyHolder = await _context.PolicyHolders
                .Include(p => p.Policies)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (policyHolder == null)
            {
                return NotFound();
            }

            return policyHolder;
        }

        // POST: api/PolicyHolders
        [HttpPost]
        public async Task<ActionResult<PolicyHolder>> PostPolicyHolder(PolicyHolder policyHolder)
        {
            _context.PolicyHolders.Add(policyHolder);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPolicyHolder), new { id = policyHolder.Id }, policyHolder);
        }
    }
}
