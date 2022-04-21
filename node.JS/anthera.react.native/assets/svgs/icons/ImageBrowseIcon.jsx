import * as React from "react"
import Svg, { Path } from "react-native-svg"

const SvgComponent = (props) => (
    <Svg xmlns="http://www.w3.org/2000/svg" width={20} height={20} {...props} viewBox="0 0 20 20">
        <Path fill={props.color} d="M20 14V2a2.006 2.006 0 0 0-2-2H6a2.006 2.006 0 0 0-2 2v12a2.006 2.006 0 0 0 2 2h12a2.006 2.006 0 0 0 2-2ZM9 10l2.03 2.71L14 9l4 5H6ZM0 4v14a2.006 2.006 0 0 0 2 2h14v-2H2V4Z" />
    </Svg>
)

export default SvgComponent
