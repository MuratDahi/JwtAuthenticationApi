using JwtAuthenticationApi.Interfaces;
using JwtAuthenticationApi.Models;

namespace JwtAuthenticationApi.Services;

public class TicketService : ITicketService
{
    private readonly ITicketRepository _ticketRepository;

    public TicketService(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<List<Ticket>> GetAllAsync()
    {
        return await _ticketRepository.GetAllAsync();
    }

    public async Task<Ticket?> GetByIdAsync(int id)
    {
        return await _ticketRepository.GetByIdAsync(id);
    }

    public async Task<Ticket> CreateAsync(Ticket ticket)
    {
        await _ticketRepository.AddAsync(ticket);
        return ticket;
    }

    public async Task<bool> UpdateAsync(int id, Ticket ticket)
    {
        var existingTicket = await _ticketRepository.GetByIdAsync(id);

        if (existingTicket == null)
            return false;

        existingTicket.Title = ticket.Title;
        existingTicket.Description = ticket.Description;
        existingTicket.Priority = ticket.Priority;
        existingTicket.Status = ticket.Status;
        existingTicket.UpdatedAt = DateTime.UtcNow;

        await _ticketRepository.UpdateAsync(existingTicket);

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var existingTicket = await _ticketRepository.GetByIdAsync(id);

        if (existingTicket == null)
            return false;

        await _ticketRepository.DeleteAsync(existingTicket);

        return true;
    }
}