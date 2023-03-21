using ECommerceMicroservicesFrontend.Models.PhotoStocks;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceMicroservicesFrontend.Services.Interfaces
{
    public interface IPhotoStockService
    {
        Task<PhotoViewModel> UploadPhoto(IFormFile photo);

        Task<bool> DeletePhoto(string photoUrl);
    }
}
