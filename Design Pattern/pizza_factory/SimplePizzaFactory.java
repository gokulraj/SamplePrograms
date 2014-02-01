//$Id$
package com.tts.dpbook.factory;

public class SimplePizzaFactory {

	public Pizza createPizza(String type) {
		Pizza pizza = null;
		if(type.equals("Cheese")){
			pizza = new CheesePizza();
		}
		else if(type.equals("Veggie")){
			pizza = new VeggiePizza();
		}
		else if(type.equals("Clam")){
			pizza = new ClamPizza();
		}
		else if(type.equals("Pepparoni")){
			pizza = new PepperoniPizza();
		}
		return pizza;
	}

}
