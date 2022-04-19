import React, {Component, createContext} from 'react';

export type AntherContextInfo={
    token: string|null,
    refreshToken:string|null,
    id:number|null,
    name:string|null,
    emailAddress:string|null,
    role:string|null,
}

type AntheraContextProps={
    children?:JSX.Element
}
export const AntherContext = createContext<AntherContextInfo|null>(null);

export class AntherContextProvider extends Component<AntheraContextProps,AntherContextInfo> {
    state:AntherContextInfo={
        token:null,
        refreshToken:null,
        id:null,
        name:null,
        emailAddress:null,
        role:null
    }
    render() {
        return (
            <AntherContext.Provider value={this.state}>
                {this.props.children}
            </AntherContext.Provider>
        );
    }
}

