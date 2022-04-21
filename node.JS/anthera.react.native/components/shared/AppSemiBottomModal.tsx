import React, { Component } from "react";
import {View, Button, Text} from "react-native";
import RBSheet from "react-native-raw-bottom-sheet";
import {AntheraStyle, screenDeviation} from "../../styles/AntheraStyle";

type SemiBottomModalProps={
    setRef: (ref:RBSheet)=>void,
    height?:number,
    openDuration?:number,
}
class AppSemiBottomModal extends Component<SemiBottomModalProps> {

    render() {
        return (
                <RBSheet
                    ref={(ref:RBSheet) => this.props.setRef(ref)}
                    height={this.props.height?this.props.height:screenDeviation(200,200,180)}
                    openDuration={this.props.openDuration?this.props.openDuration:250}
                    closeOnDragDown={true}
                    closeOnPressMask={true}
                    customStyles={{
                        wrapper: {
                            backgroundColor: "transparent"
                        },
                        draggableIcon: {
                            width:screenDeviation(30,26,28),
                            backgroundColor: AntheraStyle.colour.IconGreyLight
                        }
                    }}
                >
                    {this.props.children}
                </RBSheet>
        );
    }
}

export default AppSemiBottomModal;
