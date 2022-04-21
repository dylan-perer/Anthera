import axios, {AxiosRequestHeaders} from 'axios';
import ImagePicker from "expo-image-picker";
import {err} from "react-native-svg/lib/typescript/xml";
import {AntherContext, AntherContextInfo, AntherContextProvider} from "../contexts/AntheraContext";

const host:string = 'http://128.199.134.4';
const api:string = '/api'
const v1:string = '/v1'

const urlV1:string = host+api+v1;

type httpAction = 'GET' | 'POST' | 'PUT' | 'PATCH' | 'DELETE'

export type AntheraResponse = {
    statusCode: number|undefined,
    response: any,
    errorMsg: any
}
const identityController ='/identity';

const identityApi={
    identity:identityController,
    signup:`${identityController}/signup`,
    signin:`${identityController}/signin`,
    serverStatus:`${identityController}/serverstatus`
}

const isDebug = true;

const axiosAsync = async (httpAction:string, endpoint:string, data:any, headers:AxiosRequestHeaders ={'Content-Type': 'application/json'}, isDebug=true) => {
    const url = urlV1+endpoint;
    let httpRes:AntheraResponse = {
        statusCode:undefined,
        errorMsg:undefined,
        response:undefined
    };
    let response = null;

    try {
        if(isDebug){
            console.log(`MAKING CALL TO: ${url}`)
        }
        switch (httpAction){
            case 'GET':
                response = await axios.get(url);
                break;
            case 'POST':
                response = await axios.post(url, data, {
                    headers:headers
                });
                break;
        }
        //on success
        if(response?.status == 200){
            httpRes={
                errorMsg:undefined,
                statusCode:200,
                response:response.data
            }
        }
    } catch (caughtError) {
        const errors = caughtError.response.data?.errors;
        let errorMsg = undefined;

        if(typeof errors === 'string'){
            errorMsg=caughtError.response.data?.errors;
        }else{
            //get 1st error from array of errors
            for (const [key, value] of Object.entries(errors)) {
                // @ts-ignore
                errorMsg = value[0];
            }
        }

        return httpRes={
            errorMsg:errorMsg,
            statusCode:caughtError.response.status,
            response:undefined
        }

    }finally {
        return httpRes;
    }
};

const uploadImgAsync= async (imgUri:string,authToken:string)=>{
    // ImagePicker saves the taken photo to disk and returns a local URI to it
    let localUri:string = imgUri;
    let filename:string|undefined = localUri.split('/').pop();

    // Infer the type of the image
    let match = /\.(\w+)$/.exec(filename!=undefined?filename:'');
    let type = match ? `image/${match[1]}` : `image`;

    // Upload the image using the fetch and FormData APIs
    let formData = new FormData();
    // Assume "photo" is the name of the form field the server expects
    // @ts-ignore
    formData.append('file', { uri: localUri, name: filename, type });

    const response=await fetch(urlV1+'/user/profilepicture', {
        method: 'POST',
        body: formData,
        headers: {
            'content-type': 'multipart/form-data',
            Authorization: `Bearer ${authToken}`,

        },
    });

    let httpRes:AntheraResponse={
        statusCode:response.status,
        errorMsg:undefined,
        response:await response.json()
    }

    return httpRes;
    // if(response.status===200){
    //     const jsonPostData1 = await response.json();
    //     console.log(jsonPostData1)
    //
    // }else{
    //     const jsonPostData = await response.json();
    //     console.log(jsonPostData)
    // }
}

export type SignupRequest = {
    name?: string,
    gender?: string,
    dob?: string,
    hereTo?: string,
    emailAddress?: string,
    sexPreference?: string,
    password?: string,
    confirmPassword?: string,
}

export type SigninRequest = {
    emailAddress?: string,
    password?: string,
}

const signupAsync = async (signup:SignupRequest, antheraContext:AntherContextInfo)=>{
    const res = await axiosAsync('POST', identityApi.signup, signup);
    if(res.statusCode==200){
        antheraContext.id=res.response.user.id;
        antheraContext.name=res.response.user.name;
        antheraContext.emailAddress= res.response.user.emailAddress;
        antheraContext.token = res.response.token.accessToken;
        antheraContext.refreshToken = res.response.token.refreshToken;
    }
    return res;
}

const signinAsync = async (signin:SigninRequest)=>{
    return await axiosAsync('POST', identityApi.signin, signin);
}


export {identityApi,signupAsync,uploadImgAsync,signinAsync}
