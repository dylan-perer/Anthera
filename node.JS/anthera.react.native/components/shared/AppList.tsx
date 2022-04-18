import React, {Component} from 'react';
import {Text, View, SectionList, StyleSheet, FlatList, TouchableOpacity, SafeAreaView} from 'react-native';

type ListProps={
    data:any
    itemTemplate:({item}:any)=>JSX.Element,
    keyExtractor: (item:any)=>any
}
type ListStates={
}


class AppList extends Component<ListProps,ListStates> {
    state:ListStates={
    }

    render() {
        const renderItem = ({item}:any) => <>{this.props.itemTemplate(item)}</>;

        return (
            <View style={styles.container}>
                <FlatList data={this.props.data} renderItem={renderItem} keyExtractor={item =>this.props.keyExtractor(item)} />
            </View>
        );
    }
}
const styles = StyleSheet.create({
    container: {
        flex: 1,
    },
    item: {
        padding: 20,
        marginVertical: 8,
    },
    header: {
        fontSize: 32,
        backgroundColor: '#fff',
    },
    title: {
        fontSize: 24,
    },
});
export default AppList;
