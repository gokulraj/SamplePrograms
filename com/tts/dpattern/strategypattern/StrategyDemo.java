//$Id$
package com.tts.dpattern.strategypattern;

public class StrategyDemo {

	public static void main(String[] org){
	
		Context c = new Context(new OperationAdd());
		
		System.out.println( c.performOperation(2, 3) );
		c = new Context(new OperationSubtract());
		
		System.out.println( c.performOperation(2, 3) );
		c = new Context(new OperationMultiply());
		
		System.out.println( c.performOperation(2, 3) );
	}
}
