using Microsoft.AspNetCore.Mvc;
using repasoAPI.DTOs.Request;
using repasoAPI.DTOs.Response;
using repasoAPI.Services;

//MVC Models, Vist, Controller
namespace repasoAPI.Controllers;

[Route("api/[controller]")]
public class EstudianteController: ControllerBase
{
    // INYECCION DE DEPENDENCIAS
    private readonly IEstudianteService _estudianteService;
    
    public EstudianteController(IEstudianteService estudianteService)
    {
        this._estudianteService = estudianteService;
    }
    
    // DEFINIR ENDPOINTS (rutas urls del sitio)
    /// <summary>
    ///  Get all estudiantes
    /// </summary>
    /// <remarks>En este endpoint se retorna una lista de estudiantes en formato string</remarks>
    /// <returns>List estudiantes</returns>
    [HttpGet("[action]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<List<EstudianteResponse>>> GetAllAsync()
    {
        var response = await _estudianteService.GetAllAsync();
        return Ok(response);
    }
    
    /// <summary>
    ///  Get estudiante by id
    /// </summary>
    /// <param name="id">Estudiante id</param>
    /// <returns>Estudiante name</returns>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<EstudianteResponse>> GetByIdAsync([FromRoute] Guid id)
    {
        var response = await _estudianteService.GetByIdAsync(id);
        if (response == null || response.Id == Guid.Empty)
            return NotFound();
        
        return Ok(response);
    }

    /// <summary>
    ///  Create a new estudiante
    /// </summary>
    /// <param name="nombre">Nombre del estudiante</param>
    /// <returns>Estudiante creado</returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Guid>> CreateAsync([FromBody] EstudianteRequest request)
    {
        var response = await _estudianteService.CreateAsync(request);
        if (response == Guid.Empty)
            return BadRequest("Error al crear el estudiante");
        return CreatedAtAction(nameof(GetByIdAsync), new { id = response }, response);
    }

    /// <summary>
    ///  Update estudiante by id
    /// </summary>
    /// <param name="id">Estudiante id</param>
    /// <param name="nombre">Nuevo nombre</param>
    /// <returns>No content</returns>
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateAsync([FromBody] EstudianteRequest request)
    {
        await this._estudianteService.UpdateAsync(request);
        return NoContent();
    }

    /// <summary>
    ///  Delete estudiante by id
    /// </summary>
    /// <param name="id">Estudiante id</param>
    /// <returns>No content</returns>
    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteAsync([FromQuery] Guid id)
    {
        await this._estudianteService.DeleteAsync(id);
        return NoContent();
    }
    
    /// <summary>
    /// Get estudiantes birthdays by month
    /// </summary>
    [HttpGet("[action]/{mes}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<EstudiantesBirthdaysResponse>>> GetEstudiantesBirthdaysAsync([FromRoute] int mes)
    {
        var estudiantes = await this._estudianteService.GetEstudiantesBirthdaysAsync(mes);
        return Ok(estudiantes);
    }
}