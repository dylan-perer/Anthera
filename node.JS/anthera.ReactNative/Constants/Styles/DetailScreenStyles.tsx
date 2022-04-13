import { AntheraStyle } from "./AntheraStyles"
const DetailScreenStyles = {
    anim: {
        topTextAnim: {
            animation: {
                0: {
                    opacity: 0
                },
                1: {
                    opacity: 1
                },
                duration: 10000
            }
        },
        svgAnim: {
            animation: {
                from: {
                    opacity: 0
                },
                to: {
                    opacity: 1
                },
                duration: 10000
            }
        }

    },
    topText: {
        fontFamily: AntheraStyle.font.Questrial,
        fontSize: AntheraStyle.font.size.header,
        color: AntheraStyle.colour.TextGrey
    },
    topTextPrimary: {
        color: AntheraStyle.colour.MainBlue
    },
}



export { DetailScreenStyles }