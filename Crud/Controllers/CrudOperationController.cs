using Crud.CommonLayer.Model;
using Crud.ServiceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.RepositoryLayer;

namespace Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudOperationController : ControllerBase
    {
        public readonly ICrudSL _crudSL;
        public CrudOperationController(ICrudSL crudSL)
        {
            _crudSL = crudSL;
        }

        [HttpPost]
        [Route("CreateRecord")]
        public async Task<IActionResult> CreateRecord(CreateRecordRequest request)
        {
            CreateRecordResponse response = null;

            try
            {
                response = await _crudSL.CreateRecord(request);

            }
            catch(Exception ex)
            {
                response.IsSuccess = false;
                response.Mensaje = ex.Message;
            }
            return Ok(response);

        }

        [HttpGet]
        [Route("ReadRecord")]
        public async Task<IActionResult> ReadRecord()
        {
            ReadRecordResponse response = null;
            try
            {
                response = await _crudSL.ReadRecord();
            }
            catch(Exception ex)
            {

            }
            return Ok(response);
        }

        [HttpPut]
        [Route("UpdateRecord")]
        public async Task<IActionResult> UpdateRecord(UpdateRecordRequest request)
        {
            UpdateRecordResponse response = null;
            try
            {
                response = await _crudSL.UpdateRecord(request);
            }
            catch (Exception ex)
            {

            }
            return Ok(response);
        }

        [HttpDelete]
        [Route("DeleteRecord")]
        public async Task<IActionResult> DeleteRecord(DeleteRecordRequest request)
        {
            DeleteRecordResponse response = null;
            try
            {
                response = await _crudSL.DeleteRecord(request);
            }
            catch (Exception ex)
            {

            }
            return Ok(response);
        }
    }
}

