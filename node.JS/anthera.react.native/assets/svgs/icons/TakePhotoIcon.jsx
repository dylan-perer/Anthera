import * as React from "react"
import Svg, { G, Path } from "react-native-svg"

const SvgComponent = (props) => (
    <Svg xmlns="http://www.w3.org/2000/svg" width={100} height={100} {...props} viewBox="0 0 100 100">
        <G fill="none">
            <Path d="M50 0A50 50 0 1 1 0 50 50 50 0 0 1 50 0Z" />
            <Path
                d="M50 9.8C27.834 9.8 9.8 27.834 9.8 50c0 22.166 18.034 40.2 40.2 40.2 22.166 0 40.2-18.034 40.2-40.2C90.2 27.834 72.166 9.8 50 9.8M50 0c27.614 0 50 22.386 50 50s-22.386 50-50 50S0 77.614 0 50 22.386 0 50 0Z"
                fill={props.colourMain}
            />
        </G>
        <Path d="M50 11a39 39 0 1 1-39 39 39 39 0 0 1 39-39Z" fill={props.colourSecondary}/>
    </Svg>
)

export default SvgComponent
