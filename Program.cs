//Implemente una clase Region que implemente los atributos Nombre y Superficie.
//Implemente otra clase Pais que herede de Region y agregue los atributos OrganizacionPolitica e Idioma.
//  El primer atributo se implementará con un enumerador público con los valores: “República”, “Monarquía”, “Imperio”, “Otro”.
//Implemente otra clase Ciudad que herede de Region y agregue el atributo de tipo Boolean CiudadCapital. 
//Implemente una clase Continente que herede de Region.
//La clase Continente tendrá una colección de Paises.
//La clase Pais tendrá una colección de Ciudades de igual forma.
//Elabore la aplicación necesaria para generar instancias de las clases e invocar sus miembros.
//Calcule la superficie total de un continente teniendo en cuenta la superficie de sus países que a la vez cuentan con ciudades.
using System.Collections.Generic;


var buenosaires = new Ciudad();
buenosaires.Nombre = "Buenos Aires";
buenosaires.CiudadCapital = true;
buenosaires.Superficie =1000000;

var cordoba = new Ciudad();
cordoba.Nombre ="Cordoba";
cordoba.CiudadCapital= true;
cordoba.Superficie=50000;

var argentina = new Pais();
argentina.Ciudadades.Add(buenosaires);
argentina.Ciudadades.Add(cordoba);

class Region{
    public string Nombre { get; set; }
    public double Superficie { get; set; }
}
class Pais : Region {
    public enum eOrg{
    Republica,
    Monarquia,
    Otro,
}
    public eOrg OrganizacionPolitica { get; set; }
    public string Idioma { get; set; }
    public List<Ciudad> Ciudadades{get; set;} = new List<Ciudad>();
}
class Ciudad: Region{
    public bool CiudadCapital{get; set;}
}
class Continente : Region{
    public List<Pais> Paises{get; set;}= new List<Pais>();
}
