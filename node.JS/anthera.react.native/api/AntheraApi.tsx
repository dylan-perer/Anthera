import axios, {AxiosRequestHeaders} from 'axios';

const host:string = 'http://128.199.134.4';
const api:string = '/api'
const v1:string = '/v1'

const urlV1:string = host+api+v1;

type httpAction = 'GET' | 'POST' | 'PUT' | 'PATCH' | 'DELETE'

const identityController ='/identity';

const identityApi={
    identity:identityController,
    signup:`${identityController}/signup`,
    signin:`${identityController}/signin`,
    serverStatus:`${identityController}/serverstatus`
}

const isDebug = true;

const axiosAsync = async (httpAction:string, endpoint:string, data:any, headers:AxiosRequestHeaders, isDebug=true) => {
    const configurationObject = {
        method: httpAction,
        url:  urlV1+endpoint,
    };
    try {
        if(isDebug){
            console.log(`MAKING CALL TO: ${configurationObject.url}`)
        }
        let response = null
        switch (httpAction){
            case 'GET':
                response = await axios.get(configurationObject.url);
                break;
            case 'POST':
                response = await axios.post(configurationObject.url, data, {
                    headers:headers
                });
        }
        console.log((JSON.stringify(response?.data)));

    } catch (error) {
        if(isDebug){
            console.error(error.message);
        }
    }
};

export type SignupRequest = {
    name?: string,
    gender?: string,
    dob?: string,
    hereTo?: string,
    emailAddress?: string,
    sexPreference?: string,
    password?: string,
    confirmPassword?: string
}

const signupAsync = async (signup:SignupRequest)=>{
    const header:AxiosRequestHeaders = {
        'Content-Type': 'application/json'
    }
    await axiosAsync('POST', identityApi.signup, signup, header,isDebug)
}


export {identityApi,signupAsync}
