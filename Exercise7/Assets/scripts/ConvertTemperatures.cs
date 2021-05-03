using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        ///Declaration of variables
        int originalTemperature = 0;
        int output1st = 0;
        int outputCelcius = 0;
        int output2nd = 0;
        int outputFahrenheit = 0;

        ///operation
        ///changing fahrenheit to celcius
        output1st = originalTemperature - 32;
        outputCelcius = output1st * 5 / 9;

        ///changing celcius back to fahrenheit
        output2nd = originalTemperature * 9 / 5;
        outputFahrenheit = output2nd + 32;

        ///Output

        ///Display original temperature
        print("The original temperature : " +originalTemperature+"F");

        ///Display the output of 1st conversion
        print(originalTemperature+"F" +"is" +outputCelcius+"C");

        ///Display the output of 2nd conversion
        print(outputCelcius+"C" +"is" +outputFahrenheit+"F");
	}
	

}
