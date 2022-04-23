import React, {Component, createContext} from 'react';

export type AntherContextInfo={
    token: string|null,
    refreshToken:string|null,
    id:number|null,
    name:string|null,
    emailAddress:string|null,
    role:string|null,
    setIsUserLogged:React.Dispatch<React.SetStateAction<boolean>> | undefined
}

type AntheraContextProps={
    children?:JSX.Element,
    setIsUserLogged: React.Dispatch<React.SetStateAction<boolean>>
}
export const AntherContext = createContext<AntherContextInfo|null>(null);

export class AntherContextProvider extends Component<AntheraContextProps,AntherContextInfo> {
    state:AntherContextInfo={
        token:null,
        refreshToken:null,
        id:null,
        name:null,
        emailAddress:null,
        role:null,
        setIsUserLogged:this.props.setIsUserLogged
    }

    render() {
        return (
            <AntherContext.Provider value={this.state}>
                {this.props.children}
            </AntherContext.Provider>
        );
    }
}

