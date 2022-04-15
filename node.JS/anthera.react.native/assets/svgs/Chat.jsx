import * as React from "react"
import Svg, { Path } from "react-native-svg"

const SvgComponent = (props) => (
    <Svg xmlns="http://www.w3.org/2000/svg" width={20} height={20} {...props} viewBox="0 0 20 20">
        <Path
            d="M13.178 1.884A7.64 7.64 0 0 0 .759 5.818C.139 8.152.737 9.235.737 10.987A20.5 20.5 0 0 1 0 15.4a.528.528 0 0 0 .632.539 10.151 10.151 0 0 1 5.6-.327c7.977 2.163 13.1-8.347 6.943-13.724M19.447 20a.647.647 0 0 1-.16-.021c-6.306-1.583-5.883.2-9.387-.742a7.857 7.857 0 0 1-2.858-1.455 9.768 9.768 0 0 0 10.73-11.294 7.528 7.528 0 0 1 1.964 3.625c.849 3.936-1.306 3.27.248 9.252a.529.529 0 0 1-.537.635"
            fill="#7162fc"
            fillRule="evenodd"
        />
    </Svg>
)

export default SvgComponent
