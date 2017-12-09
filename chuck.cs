// our signal graph (patch)
 SinOsc f => dac;
 // set gain
 .3 => f.gain;
 // an array of pitch classes (in half steps)
 [ 0, 2, 4, 6, 9, 10 ] @=> int hi[];
 
 // infinite loop
 while( true )
 {
     // choose a note, shift registers, convert to frequency
     Std.mtof( 65 + Std.rand2(0,1) * 43 +
         hi[Std.rand2(0,hi.cap()-1)] ) => f.freq;
 
     // advance time by 120 ms
     120::ms => now;
 }
