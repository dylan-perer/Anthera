import * as React from "react"
import Svg, { G, Circle, Path } from "react-native-svg"

const SvgComponent = (props) => (
    <Svg xmlns="http://www.w3.org/2000/svg" width={20} height={18} {...props} viewBox="0 0 20 18">
        <G transform="translate(-2 -2)">
            <Circle fill={props.color} cx={3.2} cy={3.2} r={3.2} transform="translate(8.8 8.8)" />
            <Path fill={props.color} d="M9 2 7.17 4H4a2.006 2.006 0 0 0-2 2v12a2.006 2.006 0 0 0 2 2h16a2.006 2.006 0 0 0 2-2V6a2.006 2.006 0 0 0-2-2h-3.17L15 2Zm3 15a5 5 0 1 1 5-5 5 5 0 0 1-5 5Z" />
        </G>
    </Svg>
)

export default SvgComponent
