import {motion, AnimatePresence} from 'framer-motion';

export default function Div({isVisible}) {
    const animation = {
        hidden: {
            opacity: 0,
            x: -100
        },
        visible: {
            opacity: 1,
            x: 0,
            transition: {
                duration: 2
            }
        }
    }

    if (isVisible) {
        return (
            <AnimatePresence>
                <motion.div 
                    className='test'
                    initial={animation.hidden}
                    animate = {animation.visible}
                    exit = {animation.hidden}
                >
                        Some text
                </motion.div>
            </AnimatePresence>
        )
    }
}