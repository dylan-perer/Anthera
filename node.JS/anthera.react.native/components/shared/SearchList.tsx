import React, {Component} from 'react';
import {StyleSheet, Text, TouchableOpacity, View, ViewStyle} from 'react-native';
import List from "./List";
import BottomModal from "./BottomModal";
import SearchInput from "./SearchInput";
import {screenDeviation} from "../../styles/AntheraStyle";
import bottomModal from "./BottomModal";

type SearchListProps={
    data:any,
    modalRef:(ref:BottomModal)=>void,
    modalStyle?:ViewStyle,
    onCancel:()=>void,
    onSearchValueChange:(text:string)=>void,
    itemTemplate:({item}:any)=>JSX.Element,
    keyExtractor: (item:any)=>any
}
class SearchList extends Component<SearchListProps> {
    render() {
        return (
            <BottomModal ref={(ref:BottomModal)=>this.props.modalRef(ref)} style={[styles.bottomModal, this.props.modalStyle]}>
                <>
                    <SearchInput
                        isCancelBtn={true}
                        onCancel={this.props.onCancel}
                        onValueChange={(text => this.props.onSearchValueChange(text))}
                    />

                    <List
                        data={this.props.data}
                        keyExtractor={this.props.keyExtractor}
                        itemTemplate={this.props.itemTemplate}>
                    </List>
                </>
            </BottomModal>
        );
    }
}
const styles = StyleSheet.create({
    bottomModal:{
        maxWidth:screenDeviation(350,320,280),
    }
})

export default SearchList;
