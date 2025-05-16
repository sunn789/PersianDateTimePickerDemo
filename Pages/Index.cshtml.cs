using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using PersianDateTimePickerDemo.Models;
namespace PersianDateTimePickerDemo.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public Receipt Receipt { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        var lastPaymentDate = Receipt.LastPayment;
        return RedirectToPage();
    }
}
