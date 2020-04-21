import axios from 'axios';
const feetToInchURL = 'https://localhost:44321/api/Values/FeettoInch';
const inchToFeetURL = 'https://localhost:44321/api/Values/InchToFeet';
const meterToCentimeterURL = 'https://localhost:44321/api/Values/MetertoCentimeter';
const centimeterToMeterURL = 'https://localhost:44321/api/Values/CentimetertoMeter';

export async function feetToInch(data){
   const response = await axios.post(feetToInchURL,data);
   return response;
}

export async function inchToFeet(data){
   const response = await axios.post(inchToFeetURL,data);
   return response;
}

export async function meterToCentimeter(data){
   const response = await axios.post(meterToCentimeterURL,data);
   return response;
}

export async function centimeterToMeter(data){
   const response = await axios.post(centimeterToMeterURL,data);
   return response;
}


