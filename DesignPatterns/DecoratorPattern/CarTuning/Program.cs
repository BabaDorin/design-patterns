using CarTuning;
using CarTuning.Cars;
using CarTuning.Tunings;

// Stock Daewoo Matiz
var stockDaewoo = new DaewooMatiz();

// Single turbe daewoo matiz
var stage1Daewoo = new Turbo(new DaewooMatiz());

// Twin turbo daewoo with roll cage
var stage3Daewoo = new RollCage(new Turbo(new Turbo(new DaewooMatiz())));

// Let's race
var raceTrack = new RaceTrack(stockDaewoo, stage1Daewoo, stage3Daewoo);
raceTrack.StartRace();