import React, {Component, createContext} from 'react';
import {Text, View} from 'react-native';

type UserInfo={
    name?: string,
    gender?: string,
    dob?: string,
    hereTo?: string,
    emailAddress?: string,
    SexPreference?: string,
    password?: string,
    confirmPassword?: string,
    profilePictureUrl?:string,
    emailDuplicateError?:string
}

type UserInfoProps={
    children?:JSX.Element
}

const UserInfoContext = createContext<UserInfo|null>(null);

class UserInfoContextProvider extends Component<UserInfoProps, UserInfo> {
    state:UserInfo={

    }
    render() {
        return (
            <UserInfoContext.Provider value={this.state}>
                {this.props.children}
            </UserInfoContext.Provider>
        );
    }
}

export {UserInfoContext, UserInfoContextProvider}
