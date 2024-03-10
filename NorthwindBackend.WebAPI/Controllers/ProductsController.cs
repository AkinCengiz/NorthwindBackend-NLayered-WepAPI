using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindBackend.Business.Abstract;
using NorthwindBackend.Entities.Concrete;

namespace NorthwindBackend.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
	private IProductService _productService;

	public ProductsController(IProductService productService)
	{
		_productService = productService;
	}

	[HttpGet("getall")]
	public IActionResult GetAll()
	{
		var result = _productService.GetList();
		if (result.Success)
		{
			return Ok(result.Data);
		}
		return BadRequest(result.Message);
	}

	[HttpGet("getlistbycategoryid")]
	public IActionResult GetListByCategoryId(int id)
	{
		var result = _productService.GetListByCategoryId(id);
		if (result.Success)
		{
			return Ok(result.Data);
		}
		return BadRequest(result.Message);
	}

	[HttpGet("getlistbycategory")]
	public IActionResult GetListByCategory(Category category)
	{
		var result = _productService.GetListByCategory(category);
		if (result.Success)
		{
			return Ok(result.Data);
		}
		return BadRequest(result.Message);
	}

	[HttpGet("getbyid")]
	public IActionResult GetById(int id)
	{
		var result = _productService.GetById(id);
		if (result.Success)
		{
			return Ok(result.Data);
		}
		return BadRequest(result.Message);
	}

	[HttpPost("add")]
	public IActionResult Add(Product product)
	{
		var result = _productService.Add(product);
		if (result.Success)
		{
			return Ok(result.Message);
		}
		return BadRequest(result.Message);
	}

	[HttpPost("update")]
	public IActionResult Update(Product product)
	{
		var result = _productService.Update(product);
		if (result.Success)
		{
			return Ok(result.Message);
		}
		return BadRequest(result.Message);
	}

	[HttpPost("delete")]
	public IActionResult Delete(Product product)
	{
		var result = _productService.Delete(product);
		if (result.Success)
		{
			return Ok(result.Message);
		}
		return BadRequest(result.Message);
	}
}
