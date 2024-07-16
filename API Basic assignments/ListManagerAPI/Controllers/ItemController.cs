using ListAPI.DBO;
using Microsoft.AspNetCore.Mvc;

namespace ListAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        public ItemController() { }

        [HttpGet]
        public ActionResult GetItemById(int id)
        {
            ResponseItem item = new ResponseItem();
            try{
                if (id < 1){
                    item.Status = System.Net.HttpStatusCode.BadRequest;
                    item.Message = "Invalid Id ";
                    return new JsonResult(item);

                }
                item.Name = "Movie Set";
                item.Price = 1599;
                item.Id = id;
                item.Status = System.Net.HttpStatusCode.OK;
                item.Message = "Successful";
                
                return new JsonResult(item);
            }
            catch (Exception ex)
            {
                item.Status = System.Net.HttpStatusCode.InternalServerError;
                item.Message = ex.Message;
                return new JsonResult(item);
            }
        }
        [HttpGet("Name")]
        public ActionResult GetItemByName(string name)
        {
            ResponseItem item = new ResponseItem();
            try
            {
                if (name == null)
                {
                    item.Status = System.Net.HttpStatusCode.BadRequest;
                    item.Message = "Invalid name";
                    return new JsonResult(item);

                }
                item.Name = name;
                item.Price = 2199;
                item.Id = 2;
                item.Status = System.Net.HttpStatusCode.OK;
                item.Message = "Successful";

                return new JsonResult(item);
            }
            catch (Exception ex)
            {
                item.Status = System.Net.HttpStatusCode.InternalServerError;
                item.Message = ex.Message;
                return new JsonResult(item);
            }
        }

        [HttpPost]
        public ActionResult GetItem([FromBody]RequestItem item){
            ResponseItem newItem = new ResponseItem();
            newItem.Name = item.Name;
            newItem.Price = item.Price;
            newItem.Id = 5;
            newItem.Status = System.Net.HttpStatusCode.OK;
            newItem.Message = "Item Added Successfully";

            return new JsonResult(newItem);
        }

        [HttpPut]
        public ActionResult UpdateItem([FromBody] RequestItem item){
            ResponseItem newItem = new ResponseItem();
            newItem.Name = item.Name;
            newItem.Price = item.Price;
            newItem.Id = 6;
            newItem.Status = System.Net.HttpStatusCode.OK;
            newItem.Message = "Item Updated Successfully";

            return new JsonResult(newItem);
        }

    }
}
