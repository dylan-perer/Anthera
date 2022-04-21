import * as React from "react"
import Svg, { Path } from "react-native-svg"

const SvgComponent = (props) => (
    <Svg xmlns="http://www.w3.org/2000/svg" width={16} height={22} {...props} viewBox="0 0 16 22">
        <Path fill={props.color} d="M8 3V0L4 4l4 4V5a6 6 0 0 1 6 6 5.87 5.87 0 0 1-.7 2.8l1.46 1.46A7.986 7.986 0 0 0 8 3Zm0 14a6 6 0 0 1-6-6 5.87 5.87 0 0 1 .7-2.8L1.24 6.74A7.986 7.986 0 0 0 8 19v3l4-4-4-4Z" />
    </Svg>
)

export default SvgComponent
