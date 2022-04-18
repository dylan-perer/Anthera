import React, {Component} from 'react';
import {Modal, SafeAreaView, StatusBar, StyleSheet, TouchableWithoutFeedback, View, ViewStyle} from 'react-native';
import {AntheraStyle, onPlatform, screen, screenDeviation, verticalScale} from "../../styles/AntheraStyle";


type BottomModalProps = {
    children:JSX.Element,
    style?:(ViewStyle | undefined)[]
}
type BottomModalSate = {
    show: boolean,
}

class BottomModal extends Component<BottomModalProps, BottomModalSate> {
    state: BottomModalSate = {
        show: false,
    }
    show = () => {
        this.setState({show: true})
    }
    close = () => {
        this.setState({show: false})
    }

    render() {
        return (
            <Modal
                animationType={'slide'}
                transparent={true}
                visible={this.state.show}
                onRequestClose={this.close}
            >
                <View style={styles.container}>
                    <View style={this.props.style}>
                        {this.props.children}
                    </View>
                </View>

            </Modal>
        );
    }
}
const styles = StyleSheet.create({
    container:{
        marginTop: onPlatform(verticalScale(26),0),
        flex:1,
        paddingVertical:screenDeviation(20,20,35),
        width:screen.width,
        alignItems:'center',
        backgroundColor:AntheraStyle.colour.BackgroundGrey,
    }
})
export default BottomModal;
