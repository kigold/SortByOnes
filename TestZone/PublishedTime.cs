using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public class PublishedTime
    {
        public static string TimeDiff(DateTime date, DateTime current)
        {
            var timeDiff = (current - date).TotalMinutes;
            timeDiff = 10081;
            if (timeDiff > 10080)
            {
                //Time after 7 days
                return current.ToString("yyyy-MM-dd HH:mm");
            }
            if (timeDiff >= 1440)
            {
                //Time in  days
                return $"{Math.Round((current - date).TotalDays)} day(s) ago";
            }
            if (timeDiff >= 60)
            {
                //Time in hours
                return $"{Math.Round((current - date).TotalHours)} hour(s) ago";
            }
            if (timeDiff < 1)
            {
                //Time in Minutes
                return "now";
            }
            if (timeDiff <= 59)
            {
                //Time in Minutes
                return $"{Math.Round(timeDiff)} minute(s) ago";
            }

            return current.ToString("yyyy-MM-dd HH:mm");
        }

    }
    //Codility
    /*public class WarehouseController : Controller
    {
        private readonly IWarehouseRepository _warehouseRepository;

        public WarehouseController(IWarehouseRepository warehouseRepository)
        {
            _warehouseRepository = warehouseRepository;
        }

        // Return OkObjectResult(IEnumerable<WarehouseEntry>)
        public IActionResult GetProducts()
        {
            try
            {
                var result = _warehouseRepository.GetProductRecords(x => x.Quantity > 0);
                return Ok(result.Select(y => new WarehouseEntry
                {
                    ProductId = y.ProductId,
                    Quantity = y.Quantity
                }
                ));
            }
            catch
            {
                return BadRequest("Failed");
            }
        }

        // Return OkResult, BadRequestObjectResult(NotPositiveQuantityMessage), or BadRequestObjectResult(QuantityTooLowMessage)
        public IActionResult SetProductCapacity(int productId, int capacity)
        {
            try
            {
                if (capacity <= 0)
                {
                    var msg = new NotPositiveQuantityMessage();
                    return BadRequest(msg);
                }
                var currentRecord = _warehouseRepository.GetCapacityRecords(x => x.ProductId == productId).FirstOrDefault();
                if (currentRecord != null && capacity < currentRecord.Capacity)
                {
                    var msg = new QuantityTooLowMessage();
                    return BadRequest(msg);
                }
                _warehouseRepository.SetCapacityRecord(productId, capacity);
                return Ok();
            }
            catch
            {
                return BadRequest("Failed");
            }
        }

        // Return OkResult, BadRequestObjectResult(NotPositiveQuantityMessage), or BadRequestObjectResult(QuantityTooHighMessage)
        public IActionResult ReceiveProduct(int productId, int qty)
        {
            try
            {
                if (qty <= 0)
                {
                    var msg = new NotPositiveQuantityMessage();
                    return BadRequest(msg);
                }
                var currentCapacity = _warehouseRepository.GetCapacityRecords(x => x.ProductId == productId).FirstOrDefault();
                var currentRecord = _warehouseRepository.GetProductRecords(x => x.ProductId == productId).FirstOrDefault();
                if ((currentRecord.Quantity + qty) > currentCapacity.Capacity)
                {
                    var msg = new QuantityTooHighMessage();
                    return BadRequest(msg);
                }
                _warehouseRepository.SetProductRecord(productId, qty + currentRecord.Quantity);
                return Ok();
            }
            catch
            {
                return BadRequest("Failed");
            }
        }

        // Return OkResult, BadRequestObjectResult(NotPositiveQuantityMessage), or BadRequestObjectResult(QuantityTooHighMessage)
        public IActionResult DispatchProduct(int productId, int qty)
        {
            try
            {
                if (qty <= 0)
                {
                    var msg = new NotPositiveQuantityMessage();
                    return BadRequest(msg);
                }
                var currentRecord = _warehouseRepository.GetProductRecords(x => x.ProductId == productId).FirstOrDefault();
                if (currentRecord.Quantity < qty)
                {
                    var msg = new QuantityTooHighMessage();
                    return BadRequest(msg);
                }
                _warehouseRepository.SetProductRecord(productId, (currentRecord.Quantity - qty));
                return Ok();
            }
            catch
            {
                return BadRequest("Failed");
            }
        }
    }*/
}
