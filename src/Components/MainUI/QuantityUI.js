import React, { Component } from 'react';
import MeasurementType from '../ConversionUI/MeasurementType';
import InputTypeLeft from '../ConversionUI/InputTypeLeft';
import Formula from '../ConversionUI/Formula';
import { FaEquals } from "react-icons/fa";
import InputTypeRight from '../ConversionUI/InputTypeRight';
import {feetToInch, inchToFeet, meterToCentimeter, centimeterToMeter} from '../../Services/lengthServices';
import { kgToGm, gmToKg } from '../../Services/weightServices';
class QuantityUI extends Component {
    state = {
        showType: false,
        selectTypeLeft: "",
        selectTypeRight: "",
        inputTypeLeft: "",
        inputTypeRight: ""
    }

    measurementTypeHandler = async (event) => {
        const type = event.target.value;
        console.log(type);
        if (type === "Length") {
            console.log('inside length');
           await this.setState({
                showType: true
            })
        }
        else if (type === "Weight") {
            console.log('inside weight');
           await this.setState({
                showType: false
            })
        }
    }

    selectTypeLeftChangeHandler = async (event) => {
        const selectTypeLeft = event.target.value;
         await this.setState({
            selectTypeLeft: selectTypeLeft
        })
    }

    selectTypeRightChangeHandler =  async (event) => {
        const selectTypeRight = event.target.value;
        await this.setState({
            selectTypeRight: selectTypeRight
        })
    }

    inputTypeRightChangeHandler = async (event) => {
        const inputTypeRight = event.target.value;
       await this.setState({
            inputTypeRight: inputTypeRight
        })
    }
    inputTypeLeftChangeHandler =  async (event) => {
        const inputTypeLeft = event.target.value;
       await this.setState({
            inputTypeLeft: inputTypeLeft
        })
        console.log(this.state.inputTypeLeft);
        const input = this.state.inputTypeLeft;
        
        if((this.state.selectTypeLeft==="Feet") && (this.state.selectTypeRight==="Inch")){
            const data = {
                Feet: input
            }
            const response =  feetToInch(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }

        if((this.state.selectTypeLeft==="Inch") && (this.state.selectTypeRight==="Feet")){
            const data = {
                Inch: input
            }
            const response =  inchToFeet(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }

        if((this.state.selectTypeLeft==="Meter") && (this.state.selectTypeRight==="Centimeter")){
            const data = {
                Meter: input
            }
            const response =  meterToCentimeter(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }

        if((this.state.selectTypeLeft==="Centimeter") && (this.state.selectTypeRight==="Meter")){
            const data = {
                Centimeter: input
            }
            const response =  centimeterToMeter(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }

        if((this.state.selectTypeLeft==="Kilogram") && (this.state.selectTypeRight==="Gram")){
            const data = {
                Kilogram: input
            }
            const response =  kgToGm(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }

        if((this.state.selectTypeLeft==="Gram") && (this.state.selectTypeRight==="Kilogram")){
            const data = {
                Gram: input
            }
            const response =  gmToKg(data);
            response.then(res=>{
                 this.setState({
                    inputTypeRight:res.data
                })
            })
        }
    }

    render() {
        return (
            <div className='container m-5 d-flex justify-content-center' id='main-div'>
                <MeasurementType measurementTypeChanged={this.measurementTypeHandler} />
                <div className='row' id='main-typeconversion-div'>
                    <InputTypeLeft inputTypeLeft={this.inputTypeLeftChangeHandler} selectTypeLeft={this.selectTypeLeftChangeHandler} showType={this.state.showType} />
                    <FaEquals id='equalIcon' />
                    <InputTypeRight inputTypeRight={this.inputTypeRightChangeHandler} selectTypeRight={this.selectTypeRightChangeHandler}  valueRight={this.state.inputTypeRight} showType={this.state.showType} />
                </div>
                <Formula selectTypeLeft={this.state.selectTypeLeft} selectTypeRight={this.state.selectTypeRight}/>
            </div>
        )
    }
}
export default QuantityUI;