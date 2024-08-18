using Microsoft.AspNetCore.Mvc;
using NotificationSystem.Core.Models;
using NotificationSystem.Core.Services;

namespace NotificationSystem.API.Controller;
[ApiController]
[Route("api/[controller]")]
public class NotificationsController : ControllerBase
{
    private readonly NotificationService _notificationService;

    public NotificationsController(NotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    [HttpPost]
    public async Task<IActionResult> SendNotification([FromBody] NotificationMessage message)
    {
        await _notificationService.SendNotificationAsync(message.Title, message.Content);
        return Ok();
    }
}