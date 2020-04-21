import axios from 'axios';
const kgToGmURL = 'https://localhost:5001/api/Values/KgtoGm';
const gmToKgURL = 'https://localhost:5001/api/Values/GmtoKg';

export async function kgToGm(data){
    const response = await axios.post(kgToGmURL,data);
    return response;
 }
 export async function gmToKg(data){
    const response = await axios.post(gmToKgURL,data);
    return response;
 }