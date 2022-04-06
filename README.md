# Parcial2Scripting

Integrantes
1. Juan Esteban Ciceri
2. Juan Manuel Arciniegas
3. Valentina Franco


a la hora de enfrentar este diseño orientado a objetos, decidimos crear las siguientes clases:

Tablero: Este nos permitiría tener un escenario en el cual ocurre la acción principal del juego: el enfrentamiento entre dos cartas, pertenecientes a dos barajas distintas.

añadimos aqui tambien un metodo (SupportActive) que le permita al usuario jugar un SupportSkill caso tal lo desee, esto con el proposito de darle opciones al usuario a la hora de jugar su "turno"


Deck(Baraja): el lugar donde almacenamos todas las cartas pertenecientes a un jugador. decidimos hacer uso de una estructura de datos tipo List (lista) pues esta permite la reorganización autmatica de todos los elementos en ella caso tal se añada o remueva un elemento intermedio en la misma. (esto es bastante útil considerando que se añaden y remueven elementos a la baraja constantemente)


Encontramos un caso de polimorfismo y herencia en los distintos tipos de carta, para este creamos:
  Una clase Abstracta Carta: decidimos hacer uso de este tipo de clase pues para nuestra solucion nunca es necesario la creación de un objeto padre Carta
  considerando que el problema a solucionar solo tiene en cuenta los distintos tipos de cartas.
  
  en la cual almacenamos todos los atributos comunes que poseen todos los 3 tipos de carta:
      - Nombre
      - CostPoints
      - Rarity (el cual interpretamos como un enum con los distintos tipos de rareza en nuestra solución)
      
  y 3 Clases hijas, entre ellas:
  
  
  Character: la cual segun la descripción de la solución debía contener una total de 3 cartas tipo Equip, para esto un usuamos nuevamente una List<Equip>
  para almacenar estos elementos, pues nuevamente, hay factores como el supportSkill que remueven elementos de la lista y requieren el reacomodamiento de   los elementos.
  
  la afinidad de Character fue también resuelta con un enum. siguiendo las indicaciones planteadas en la solución, las cartas Equip solo pueden ser añadidas a una carta Character con la misma Afinidad
    
  el metodo AnadirEquip remueve las cartas deseadas de la baraja y las añade a la lista de equip de la carta Character, asi cuando la carta Character es  destruida en combate, todo su equpamiento lo hace consigo.
  
  Equip: los tipos de efecto que tienen sobre las cartas tipo Character son nuevamente definidos mediante un enum.
  
  SupportSkill: el tipo de efecto tambien se solucina usando un enum. son de único uso. al llamar al metodo correspondiente, estas se remueven de la barja.
  
  
  
  
  
      

