import React, {Component} from 'react';
import {StyleSheet, Text, TouchableOpacity, View, ViewStyle} from 'react-native';
import AppList from "./AppList";
import AppBottomModal from "./AppBottomModal";
import AppSearchInput from "./AppSearchInput";
import {screenDeviation} from "../../styles/AntheraStyle";
import bottomModal from "./AppBottomModal";

type SearchListProps={
    data:any,
    modalRef:(ref:AppBottomModal)=>void,
    modalStyle?:ViewStyle,
    onCancel:()=>void,
    onSearchValueChange:(text:string)=>void,
    itemTemplate:({item}:any)=>JSX.Element,
    keyExtractor: (item:any)=>any
}
class AppSearchList extends Component<SearchListProps> {
    render() {
        return (
            <AppBottomModal ref={(ref:AppBottomModal)=>this.props.modalRef(ref)} style={[styles.bottomModal, this.props.modalStyle]}>
                <>
                    <AppSearchInput
                        isCancelBtn={true}
                        onCancel={this.props.onCancel}
                        onValueChange={(text => this.props.onSearchValueChange(text))}
                    />

                    <AppList
                        data={this.props.data}
                        keyExtractor={this.props.keyExtractor}
                        itemTemplate={this.props.itemTemplate}>
                    </AppList>
                </>
            </AppBottomModal>
        );
    }
}
const styles = StyleSheet.create({
    bottomModal:{
        maxWidth:screenDeviation(350,320,280),
    }
})

export default AppSearchList;
