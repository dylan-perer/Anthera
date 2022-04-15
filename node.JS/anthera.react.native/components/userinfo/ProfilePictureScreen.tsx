import UserInfo from "./UserInfo";
import FemaleAvatar from "../../assets/svgs/FemaleAvatar";
import {StyleSheet, TouchableOpacity} from "react-native";
import {isPhoneScreen, isSmallPhoneScreen, moderateScale} from "../../styles/AntheraStyle";

const ProfilePictureScreen=({navigation}:{navigation:any})=>{
    const onContinue = () => {

    }

    return <UserInfo
        tilePrefix={'Nice one! Now all we need to is to add a '}
        titleHighLighted={'profile '}
        titlePostfix={'picture.'}
        hint={'Choose your best! You can add more or change photos later.'}
        onContinue={onContinue}
        onGoBack={()=>navigation.navigate('EmailAndPasswordScreen')}>
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
        borderRadius:moderateScale(40)
    },
    svg:{
        width: isSmallPhoneScreen? moderateScale(100): isPhoneScreen? moderateScale(150):moderateScale(120),
        height:isSmallPhoneScreen? moderateScale(100): isPhoneScreen? moderateScale(150):moderateScale(120),
    }
})
export default ProfilePictureScreen;
