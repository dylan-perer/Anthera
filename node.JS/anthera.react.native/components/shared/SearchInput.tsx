import React, {Component} from 'react';
import {StyleSheet, Text, TextInput, TouchableOpacity, View} from 'react-native';
import SearchIcon from "../../assets/svgs/icons/SearchIcon";
import {AntheraStyle, moderateScale, screenDeviation, verticalScale} from "../../styles/AntheraStyle";

type SearchInputProps={
    placeholder?:string,
    onValueChange:(text:string)=>void,
    isCancelBtn?:boolean,
    autoFocus?:boolean,
    onCancel?:()=>void
}
type SearchInputStates={
}
class SearchInput extends Component<SearchInputProps,SearchInputStates>{
    state:SearchInputStates={
    }

    render() {
        return (
            <View style={styles.container}>
                <View style={styles.inputContainer}>
                    <SearchIcon {...styles.icon}/>
                    <TextInput
                        style={[styles.textInput, this.props.isCancelBtn?{}:{width:'100%'}]}
                        placeholder={this.props.placeholder?this.props.placeholder:'Search'}
                        onChangeText={(text)=>this.props.onValueChange(text)}
                        autoFocus={this.props.autoFocus?this.props.autoFocus:true}
                    />

                </View>
                    {this.props.isCancelBtn&&<TouchableOpacity style={styles.cancelBtn} onPress={this.props.onCancel}>
                        <Text style={[styles.cancelBtnText,{color:AntheraStyle.colour.main}]}>Cancel</Text>
                    </TouchableOpacity>}
            </View>
        );
    }
}
const styles = StyleSheet.create({
    container:{
        flexDirection:'row',
        justifyContent:'space-between',
        alignItems:'center',
        width:'100%',

    },
    inputContainer:{
        backgroundColor:'#e6e6e6',
        flexDirection:'row',
        justifyContent:'flex-start',
        alignItems:'center',
        flex:1,
        borderRadius:screenDeviation(10,10,8),
        height:screenDeviation(40,35,30),
    },
    icon:{
        color:AntheraStyle.colour.TextGreyLight,
        width:screenDeviation(20, 14, 12),
        height:screenDeviation(20, 14, 12),
        marginRight:screenDeviation(10,8,7),
        marginLeft:screenDeviation(8,8,6)
    },
    textInput:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.textSmall,
        color:AntheraStyle.colour.TextGrey,
        alignSelf:'center',
        flex:1
    },
    cancelBtn:{
        width:screenDeviation(70, 65, 60),
        height:screenDeviation(40, 38, 35),
        justifyContent:'center',
        alignItems:'center'
    },
    cancelBtnText:{
        fontFamily:AntheraStyle.font.nuntito_SemiBold,
        fontSize:AntheraStyle.font.size.textSmall,
        color:AntheraStyle.colour.main,
    }
})
export default SearchInput;
