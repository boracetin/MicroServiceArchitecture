using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionService.API.Dtos;

namespace SessionService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        public SessionController()
        {

        }


        [HttpGet()]
        [Route("GetCurrentSessinInformation")]
        public GetCurrentSessinInformationOutputDto GetCurrentSessinInformation (GetCurrentSessinInformationInputDto input)
        {
            //Tenant id bilgisine göre diğer servislere senkron bir api istediği atılacak 
            //2 adet senaryo mevcut durumda rabbitmq ya bağlayıp sistemi asekron yapabilirim ama bu da mnantıklı değil
            //Doğrudan katmanları birbirine bağlasam ve servis sekron çalışsa istediğim oluyor ama mikroservise yaklaşımından uyzaklaimıus oluyorum. Prof birisine sor.
            //Servislerden donen bildiyi Redis kurup onun içinde tut.


            GetCurrentSessinInformationOutputDto getCurrentSessinInformationOutputDto= new GetCurrentSessinInformationOutputDto();



            return getCurrentSessinInformationOutputDto;
        }
    }
}
