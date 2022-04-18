import UserInfo from "./UserInfo";
import FemaleAvatar from "../../assets/svgs/FemaleAvatar";
import {StyleSheet, TouchableOpacity} from "react-native";
import {isPhoneScreen, isSmallPhoneScreen, moderateScale, screenDeviation} from "../../styles/AntheraStyle";

const ProfilePictureScreen=({navigation}:{navigation:any})=>{
    const onContinue = () => {

    }

    return <UserInfo
        tilePrefix={'Nice one! Time for an '}
        titleHighLighted={'profile picture.'}
        titlePostfix={''}
        hint={'Choose your best! You can add more or change photos later.'}
        onContinue={onContinue}
        onGoBack={()=>navigation.navigate('EmailAndPasswordScreen')}
        btnStyle={{marginTop: screenDeviation(60,65,80)}}
    >
        <TouchableOpacity style={styles.profilePictureContainer}>
            <FemaleAvatar {...styles.svg}/>
        </TouchableOpacity>
    </UserInfo>
}


const styles = StyleSheet.create({
    profilePictureContainer:{
        alignSelf:'center',
        flexDirection:'row',
        justifyContent:'center',
        // backgroundColor:'red',
        width:isSmallPhoneScreen? moderateScale(100): isPhoneScreen? moderateScale(150):moderateScale(120),
        borderRadius:moderateScale(40),
        marginTop: screenDeviation(45,15,15)
    },
    svg:{
        width: isSmallPhoneScreen? moderateScale(120): isPhoneScreen? moderateScale(150):moderateScale(120),
        height:isSmallPhoneScreen? moderateScale(120): isPhoneScreen? moderateScale(150):moderateScale(120),
    }
})
export default ProfilePictureScreen;
