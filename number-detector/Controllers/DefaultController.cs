using Microsoft.AspNetCore.Mvc;

namespace number_detector.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DefaultController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] ImageData data)
        {
            // Здесь нужно добавить обработку изображения: декодировать dataURL, масштабировать до нужного формата,
            // запустить модель нейросети для распознавания, и вернуть результат.
            // Пока для демонстрации вернем заглушку.

            // Пример: возвращаем, что распознали цифру 7
            return Ok(new { prediction = "7" });
        }
    }

    public class ImageData
    {
        public string Image { get; set; }
    }
}
