import * as React from "react"
import Svg, { Path } from "react-native-svg"

const SvgComponent = (props) => (
    <Svg
        xmlns="http://www.w3.org/2000/svg"
        width={17.49}
        height={17.49}
        viewBox="0 0 17.49 17.49"
        {...props}
    >
        <Path
            d="M12.5 11h-.79l-.28-.27a6.51 6.51 0 1 0-.7.7l.27.28v.79l5 4.99L17.49 16Zm-6 0A4.5 4.5 0 1 1 11 6.5 4.494 4.494 0 0 1 6.5 11Z"
            fill={props.color}
        />
    </Svg>
)

export default SvgComponent
