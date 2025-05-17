import {Modal, Pressable, View, Text, StyleSheet} from "react-native";

const HelloModal = ({modalVisible, setModalVisible}) => {
    return (
        <Modal
            animationType="slide"
            transparent={true}
            visible={modalVisible}
            onRequestClose={() => setModalVisible(false)}
        >
            <View style={styles.container}>
                <Text>Привет!</Text>
                    <Pressable onPress={() => setModalVisible(false)}>
                        <Text>Закрыть</Text>
                    </Pressable>
            </View>
        </Modal>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: 'red',
        alignItems: 'center',
        justifyContent: 'center',
        width: '40%',
        height: '40%'
    },
});

export { HelloModal };