import React, { useState, useEffect } from 'react';
import {StyleSheet, Text, View, TouchableOpacity, Image} from 'react-native';
import { Camera } from 'expo-camera';
import {AntheraStyle, moderateScale, screen, screenDeviation} from "../../styles/AntheraStyle";
import * as ImagePicker from 'expo-image-picker';
import {uploadImgAsync} from "../../api/AntheraApi";

const AppCamera = ()=> {
    const [hasPermission, setHasPermission] = useState(null);
    const [camera, setCamera] = useState(null);
    const [image, setImage] = useState(null);
    const [type, setType] = useState(Camera.Constants.Type.back);

    const takePictureAsync = async ()=>{
        // Display the camera to the user and wait for them to take a photo or to cancel
        let result = await ImagePicker.launchCameraAsync({
            allowsEditing: true,
            aspect: [4, 5],
        });

        if (result.cancelled) {
            return;
        }

        await uploadImgAsync(result.uri,'aa');
    }

    useEffect(() => {
        (async () => {
            await takePictureAsync();
        })();
    }, []);

    if (hasPermission === null) {
        return <View />;
    }
    if (hasPermission === false) {
        return <Text>No access to camera</Text>;
    }

    const flip = ()=> {
        setType(
            type === Camera.Constants.Type.back
                ? Camera.Constants.Type.front
                : Camera.Constants.Type.back
        );
    }
    return (
        <></>
    );
}

const styles = StyleSheet.create({
    container: {
        flex:1,
    },
    cameraContainer: {
        flex:1,
        justifyContent:'flex-end',
        backgroundColor:'#000'
    },
    camera: {
        height:screen.height,
        justifyContent:'flex-end',
        // aspectRatio: 1//forces it to be 1:1
    },
    buttonContainer: {
        flexDirection:'row',
        justifyContent:"center",
        alignItems:'center',
        marginBottom:screenDeviation(20,30,70)
    },
    btnTakePic: {
        width:screenDeviation(75,65,70),
        height:screenDeviation(75,65,70),
    },
    btnFlip: {
        width:screenDeviation(25,22,25),
        height:screenDeviation(25,22,25),
    },
    text: {
        color: 'red',
    }
});

export default AppCamera;
