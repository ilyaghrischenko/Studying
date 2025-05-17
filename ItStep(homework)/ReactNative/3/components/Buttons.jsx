import {Button, StyleSheet, View} from "react-native";

const Buttons = () => {
    return (
        <View>
            <Button color={'#6278F2'} title={"Sign In"} />
            <Button color={'#E6EBF3'} title={"Sign Up"} />
            <Button color={'#9994AF99'} title={"Continue as Guest"} />
        </View>
    );
};

const styles = StyleSheet.create({
});

export { Buttons };