import React, {Component} from 'react';
import {Text, TouchableOpacity, View, ViewStyle} from 'react-native';
import List from "./List";
import BottomModal from "./BottomModal";
import SearchInput from "./SearchInput";

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
            <BottomModal ref={(ref:BottomModal)=>this.props.modalRef(ref)} style={this.props.modalStyle}>
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

export default SearchList;
