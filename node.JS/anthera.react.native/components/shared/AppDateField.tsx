import {StyleSheet, Text, TextInput, View, ViewStyle} from "react-native";
import {AntheraStyle, moderateScale} from "../../styles/AntheraStyle";
import {useRef} from "react";
import AppError from "./AppError";

type DateFieldProps = {
    errorMsg: string
    onValue: any
    autoFocus?: boolean
    styleContainer?: ViewStyle
}

const AppDateField = (props: DateFieldProps) => {
    const d1: any = useRef();
    const d1Value: any = useRef();

    const d2: any = useRef();
    const d2Value: any = useRef();

    const m1: any = useRef();
    const m1Value: any = useRef();

    const m2: any = useRef();
    const m2Value: any = useRef();

    const y1: any = useRef();
    const y1Value: any = useRef();

    const y2: any = useRef();
    const y2Value: any = useRef();

    const y3: any = useRef();
    const y3Value: any = useRef();

    const y4: any = useRef();
    const y4Value: any = useRef();

    const setFocusOnBackspace = (nativeEvent: any, backRef: any) => {
        if (backRef != null && nativeEvent.key === 'Backspace') {
            backRef.current.focus();
        }
    }
    const setFocus = (text: string, setValue: any, ref: any, backRef: any) => {
        if (ref != null && text.length > 0) {
            ref.current.focus();
            ref.current.select
        } else if (backRef != null && text.length == 0) {
            backRef.current.focus();
        }
        setValue.current = text;
        props.onValue(y1Value.current + y2Value.current + y3Value.current + y4Value.current + '-' + m1Value.current + m2Value.current + '-' + d1Value.current + d2Value.current)
    }
    return (<>
            <View style={[styles.inputBorder, props.styleContainer]}>
                <TextInput
                    autoFocus={props.autoFocus}
                    placeholder={'D'}
                    maxLength={1}
                    keyboardType={'numeric'}
                    ref={d1}
                    selectTextOnFocus={true}
                    style={[styles.input]}
                    onChangeText={(text) => {
                        setFocus(text, d1Value, d2, null)
                    }}/>

                <TextInput
                    placeholder={'D'}
                    maxLength={1}
                    keyboardType={'numeric'}
                    selectTextOnFocus={true}
                    style={[styles.input]}
                    ref={d2}
                    onKeyPress={({nativeEvent}) => {
                        setFocusOnBackspace(nativeEvent, d1)
                    }}
                    onChangeText={(text) => {
                        setFocus(text, d2Value, m1, d1)
                    }}/>

                <Text style={[styles.input, styles.inputEnd]}>-</Text>

                <TextInput
                    placeholder={'M'}
                    maxLength={1}
                    selectTextOnFocus={true}
                    keyboardType={'numeric'}
                    style={[styles.input]}
                    onKeyPress={({nativeEvent}) => {
                        setFocusOnBackspace(nativeEvent, d2)
                    }}
                    ref={m1} onChangeText={(text) => {
                    setFocus(text, m1Value, m2, d2)
                }}/>


                <TextInput
                    placeholder={'M'}
                    maxLength={1}
                    keyboardType={'numeric'}
                    selectTextOnFocus={true}
                    style={[styles.input]}
                    ref={m2}
                    onKeyPress={({nativeEvent}) => {
                        setFocusOnBackspace(nativeEvent, m1)
                    }}
                    onChangeText={(text) => {
                        setFocus(text, m2Value, y1, m1)
                    }}/>


                <Text style={[styles.input, styles.inputEnd]}>-</Text>

                <TextInput
                    placeholder={'Y'}
                    maxLength={1}
                    keyboardType={'numeric'}
                    selectTextOnFocus={true}
                    style={[styles.input]}
                    ref={y1}
                    onKeyPress={({nativeEvent}) => {
                        setFocusOnBackspace(nativeEvent, m2)
                    }}
                    onChangeText={(text) => {
                        setFocus(text, y1Value, y2, m2)
                    }}/>

                <TextInput
                    placeholder={'Y'}
                    maxLength={1}
                    keyboardType={'numeric'}
                    selectTextOnFocus={true}
                    style={[styles.input]}
                    ref={y2}
                    onKeyPress={({nativeEvent}) => {
                        setFocusOnBackspace(nativeEvent, y1)
                    }}
                    onChangeText={(text) => {
                        setFocus(text, y2Value, y3, y1)
                    }}/>

                <TextInput
                    placeholder={'Y'}
                    maxLength={1}
                    keyboardType={'numeric'}
                    style={[styles.input]}
                    selectTextOnFocus={true}
                    ref={y3}
                    onKeyPress={({nativeEvent}) => {
                        setFocusOnBackspace(nativeEvent, y2)
                    }}
                    onChangeText={(text) => {
                        setFocus(text, y3Value, y4, y2)
                    }}/>

                <TextInput
                    placeholder={'Y'}
                    maxLength={1}
                    keyboardType={'numeric'}
                    style={[styles.input]}
                    selectTextOnFocus={true}
                    ref={y4}
                    onKeyPress={({nativeEvent}) => {
                        setFocusOnBackspace(nativeEvent, y3)
                    }}
                    onChangeText={(text) => {
                        setFocus(text, y4Value, null, y3)
                    }}/>
            </View>
            <View style={styles.errorAndCounterContainer}>
                <AppError errorMsg={props.errorMsg} style={{alignSelf: 'center'}}/>
            </View>
        </>
    );
}


const styles = StyleSheet.create({
    inputBorder: {
        flexDirection: 'row',
        justifyContent: 'center'
    },
    input: {
        fontFamily: AntheraStyle.font.nunito_regular,
        color: AntheraStyle.colour.TextGrey,
        fontSize: AntheraStyle.font.size.textMedium
    },
    inputEnd: {
        marginHorizontal: moderateScale(5)
    },
    separator: {},
    labelContainer: {
        flexDirection: 'row',
        justifyContent: 'space-between',
        width: moderateScale(180),
        alignSelf: 'center'
    },
    label: {
        fontFamily: AntheraStyle.font.nunito_regular,
        color: AntheraStyle.colour.TextGrey,
        fontSize: AntheraStyle.font.size.textSmall,
    },
    labelDay: {},
    labelMonth: {},
    labelYear: {},
    errorAndCounterContainer: {}
});
export default AppDateField;
