using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Autolavado.Models;
using Microsoft.IdentityModel.Tokens;

namespace Autolavado.Token;

public class JwtGenetaror : IJwtGenerator
{

    public string CrearToken(Usuario usuario)
    {
        //Se crea el paylod del Token
        var claims = new List<Claim>{
        new Claim(JwtRegisteredClaimNames.NameId,usuario.UserName!),
        new Claim("userId",usuario.Id),
        new Claim("email",usuario.Email!)
       };
        //llave de seguridad del token
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MIKeYSecurity"));
        //Crear Credenciales del token
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
        //Instancial el cuerpo del token
        var tokenDescription = new SecurityTokenDescriptor
        {
            //payload del Token
            Subject = new ClaimsIdentity(claims),
            //Dias de acceso o vencimiento del token
            Expires = DateTime.Now.AddDays(30),
            //Credenciales de acceso
            SigningCredentials = credentials
        };
        //Decodifica y genera el token
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescription);
        // Retorna el token
        return tokenHandler.WriteToken(token);
    }

}